$(function () {
	console.log("document ready");
	$(document).on("click", ".edit-product-button", function () {
		console.log("You clicked button number " + $(this).val());

		var productId = $(this).val();

		$.ajax({
			type: 'json',
			data: {
				"id" : productId
			},
			url: '/product/DetailsJSON',
			success: function (data) {
				console.log(data)

				$("#modal-input-id").val(data.id);
				$("#modal-input-name").val(data.name);
				$("#modal-input-price").val(data.price);
				$("#modal-input-description").val(data.description);
			}
		})
	});
	$("#save-button").click(function () {
		// get values from input and create on json

		var Product = {
			"Id": $("#modal-input-id").val(),
			"Name": $("#modal-input-name").val(),
			"Price": $("#modal-input-price").val(),
			"Description": $("#modal-input-description").val()
		};

		console.log("saved:");
		console.log(Product);

		// save the updated product
		$.ajax({
			type: 'json',
			data: Product,
			url: '/product/EditReturnPartial',
			success: function (data) {
				console.log(data);
				$("#card-number-" + Product.Id).html(data).hide().fadeIn(2000);
			}
		})
	})
});