import 'https://api.mapbox.com/mapbox-gl-js/v1.12.0/mapbox-gl.js';

mapboxgl.accessToken = 'pk.eyJ1IjoiY21jaW50eXJlLW1zIiwiYSI6ImNsM2VnaDRtMDBicnkzanA2bnJubjhyNTMifQ.8cL2NLq5E80dWjZtqikUag';

export function addMapToElement(element, longitude, latitude) {
    const map = new mapboxgl.Map({
        container: element,
        style: 'mapbox://styles/mapbox/streets-v11',
        center: [longitude, latitude],
        zoom: 15
    });



    new mapboxgl.Marker().setLngLat([longitude, latitude]).addTo(map);
    return map;
}

export function setMapCenter(map, latitude, longitude) {
    map.setCenter([longitude, latitude]);
}