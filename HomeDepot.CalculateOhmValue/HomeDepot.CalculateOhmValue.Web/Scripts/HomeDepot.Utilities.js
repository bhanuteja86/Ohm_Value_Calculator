(function (HomeDepotUtilities) {
	HomeDepotUtilities.formAjaxSubmit = function (event) {
		event.preventDefault();

		var $form = $(event.target);

		if (!$form.valid()) return;

		$.ajax({
			url: $form.attr('action'),
			type: $form.attr('method'),
			data: $form.serialize(),
			beforeSend: function () {
				
			},
			success: function (result) {
				HomeDepotUtilities.processAjaxResponse(result)
			},
			complete: function () {
				
			}
		});
	};


	HomeDepotUtilities.processAjaxResponse = function (html) {
		var $response = $('<div/>').html(html);

		$response.children().each(function () {
			var $source = $(this),
            id = $source.attr('id'),
            $dest = $('#' + id);

			$dest.replaceWith($source);
			
		})
	};


}(window.HomeDepotUtilities = window.HomeDepotUtilities || {}));