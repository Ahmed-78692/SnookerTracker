// Snooker Tracker - Production Offline Service Worker
// Uses the Blazor-generated asset manifest for complete offline support

self.importScripts('./service-worker-assets.js');

const CACHE_NAME = `snooker-tracker-${self.assetsManifest.version}`;

self.addEventListener('install', event => {
    event.waitUntil(
        (async () => {
            const cache = await caches.open(CACHE_NAME);
            const assets = self.assetsManifest.assets
                .filter(asset => asset.hash)
                .map(asset => new Request(asset.url, { integrity: asset.hash, cache: 'no-cache' }));
            
            for (const request of assets) {
                try {
                    await cache.add(request);
                } catch (e) {
                    // Skip assets that fail (non-critical)
                    console.warn(`Failed to cache: ${request.url}`);
                }
            }
            
            // Also cache the root
            await cache.add('./');
            self.skipWaiting();
        })()
    );
});

self.addEventListener('activate', event => {
    event.waitUntil(
        (async () => {
            const keys = await caches.keys();
            await Promise.all(
                keys.filter(key => key !== CACHE_NAME).map(key => caches.delete(key))
            );
            self.clients.claim();
        })()
    );
});

self.addEventListener('fetch', event => {
    // Only handle GET requests
    if (event.request.method !== 'GET') return;

    // Don't cache API calls or external requests
    const url = new URL(event.request.url);
    if (url.origin !== self.location.origin) return;

    event.respondWith(
        (async () => {
            const cache = await caches.open(CACHE_NAME);
            const cached = await cache.match(event.request);

            if (cached) {
                return cached;
            }

            try {
                const response = await fetch(event.request);
                if (response.ok) {
                    cache.put(event.request, response.clone());
                }
                return response;
            } catch {
                // If offline and not cached, return the index for navigation requests
                if (event.request.mode === 'navigate') {
                    return cache.match('./index.html');
                }
                return new Response('Offline', { status: 503 });
            }
        })()
    );
});
