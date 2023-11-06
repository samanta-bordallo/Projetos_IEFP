$(document).ready(function () {
    $('#Projects').DataTable({
        language: {
            decimal: "",
            emptyTable: "No data available in table",
            info: "Showing _START_ to _END_ of _TOTAL_ entries",
            infoEmpty: "Showing 0 to 0 of 0 entries",
            infoFiltered: "(filtered from _MAX_ total entries)",
            infoPostFix: "",
            thousands: ",",
            lengthMenu: "Show _MENU_ entries",
            loadingRecords: "Loading...",
            processing: "Processing...",
            search: "Search:",
            zeroRecords: "No matching records found",
            paginate: {
                first: "First",
                last: "Last",
                next: "Next",
                previous: "Previous"
            },
            aria: {
                sortAscending: ": activate to sort column ascending",
                sortDescending: ": activate to sort column descending"
            }
        }
    });
});


function zoomImage(img) {
const zoomedImg = document.createElement('div');
zoomedImg.style.position = 'fixed';
zoomedImg.style.top = '0';
zoomedImg.style.left = '0';
zoomedImg.style.width = '100%';
zoomedImg.style.height = '100%';
zoomedImg.style.backgroundColor = 'rgba(0, 0, 0, 0.7)';
zoomedImg.style.display = 'flex';
zoomedImg.style.alignItems = 'center';
zoomedImg.style.justifyContent = 'center';

const imgElement = document.createElement('img');
imgElement.src = img.src;
imgElement.style.maxWidth = '90%';
imgElement.style.maxHeight = '90%';

zoomedImg.appendChild(imgElement);

zoomedImg.addEventListener('click', function () {
    document.body.removeChild(zoomedImg);
});

document.body.appendChild(zoomedImg);
}

const images = document.querySelectorAll('img');

images.forEach(function (img) {
    img.addEventListener('click', function () {
        zoomImage(img);
    });
});

document.getElementById('expand-link').addEventListener('click', function (event) {
    event.preventDefault();  // Impede o link de redirecionar

    const imageContainer = document.getElementById('image-container');
    imageContainer.style.display = 'block';
});
