function googleTranslateElementInit() {
	new google.translate.TranslateElement({
		autoDisplay: false
	}, 'google_translate_element');
}

function changeLanguage(lang) {
	var selectElement = document.querySelector(".goog-te-combo");
	selectElement.value = lang;
	selectElement.dispatchEvent(new Event('change'));
}