function showPostDeleteModel(recordId) {
	console.log(recordId);

	$("#fldDeletePostId").val(recordId);
	$('#deletePostModal').modal('show');
}

function deletePost(button) {

	var url = $(button).attr('data-url');
	console.log(url);

	var id = $("#fldDeletePostId").val();
	console.log(id);
	$.ajax({
		type: "POST",
		url: url,
		data: { 'id': id },
		datatype: "html",
		success: function (data) {
			if (data.result) {

				if (data.urlAction != null) {
					swal({
						title: "Result",
						text: data.message,
						icon: "success"
					}).then(name => {
						window.location.href = data.urlAction;
					});
				} else {
					swal({
						title: "Result",
						text: data.message,
						icon: "success"
					});
				}


			} else {
				swal({
					title: "Result",
					text: data.message,
					icon: "error"
				});
			}
		}
	});
}