function initMap() {
    var myOptions = {
        zoom: 15,
        center: new google.maps.LatLng(10.8555748,106.782914),
        mapTypeId: google.maps.MapTypeId.ROADMAP
    };
    map = new google.maps.Map(document.getElementById('map'), myOptions);
    marker = new google.maps.Marker({
        map: map,
        position: new google.maps.LatLng(21.0477359,105.7495967)
    });
    infowindow = new google.maps.InfoWindow({
        content: '<img src="<?php echo get_template_directory_uri() ?>/images/logo-vn4u.png" alt="" style="width:90px; "><div>Công ty Vn4U</div>'
    });
    google.maps.event.addListener(marker, 'click', function() {
        infowindow.open(map, marker);
    });
    infowindow.open(map, marker);
}
google.maps.event.addDomListener(window, 'load', initMap);


<script async defer
src="https://maps.googleapis.com/maps/api/js?key=AIzaSyClDTNDu-sFnqtFRMySjpoQWWgxmQxPGUg&callback=initMap&language=en">
</script>