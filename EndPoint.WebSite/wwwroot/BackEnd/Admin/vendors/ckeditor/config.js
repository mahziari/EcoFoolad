/**
 * @license Copyright (c) 2003-2019, CKSource - Frederico Knabben. All rights reserved.
 * For licensing, see https://ckeditor.com/legal/ckeditor-oss-license
 */

CKEDITOR.editorConfig = function( config ) {
    config.language = 'fa';
    config.extraPlugins = 'image';
    config.contentsLangDirection = 'rtl';
    config.filebrowserImageUploadUrl = '~/Images/CkEditor';
    // config.uiColor = '#AADC6E';
    config.toolbar = 'MyToolbar';

    // config.codeSnippet_theme = 'atelier-seaside.light';
    // CKEDITOR.config.allowedContent = true;
    // config.extraPlugins = 'codesnippet';

    config.toolbar_MyToolbar =
        [
            { name: 'document', items: ['Source', '-', 'Save', 'NewPage', 'DocProps', 'Preview', 'Print', '-', 'Templates'] },
            { name: 'clipboard', items: ['Cut', 'Copy', 'Paste', 'PasteText', 'PasteFromWord', '-', 'Undo', 'Redo'] },
            { name: 'editing', items: ['Find', 'Replace', '-', 'SelectAll', '-', 'SpellChecker', 'Scayt'] },
            { name: 'forms', items: ['Form', 'Checkbox', 'Radio', 'TextField', 'Textarea', 'Select', 'Button', 'ImageButton', 'HiddenField'] },
            { name: 'basicstyles', items: ['Bold', 'Italic', 'Underline', 'Strike', 'Subscript', 'Superscript', '-', 'RemoveFormat'] },
            { name: 'links', items: ['Link', 'Unlink', 'Anchor'] },
            { name: 'colors', items: ['TextColor', 'BGColor'] },
            '/',
            { name: 'insert', items: ['Image', 'Flash', 'Table', 'HorizontalRule', 'Smiley', 'SpecialChar', 'PageBreak', 'Iframe'] },
            { name: 'paragraph', items: ['NumberedList', 'BulletedList', '-', 'Outdent', 'Indent', '-', 'Blockquote', 'CreateDiv', '-', 'JustifyLeft', 'JustifyCenter', 'JustifyRight', 'JustifyBlock', '-', 'BidiLtr', 'BidiRtl'] },
            { name: 'styles', items: ['Styles', 'Format', 'Font', 'FontSize'] }

        ];

    // config.filebrowserBrowseUrl= '~/BackEnd/Admin/vendors/ckfinder/ckfinder.html?type=Images';
    // config.filebrowserUploadUrl= '~/BackEnd/Admin/vendors/ckfinder/connector?command=QuickUpload&type=Files';
    // config.filebrowserImageBrowseUrl= '/BackEnd/Admin/vendors/ckfinder/ckfinder.html?type=Images';
    // config.filebrowserFlashBrowseUrl= '/BackEnd/Admin/vendors/ckfinder/ckfinder.html?type=Flash';
    // config.filebrowserImageUploadUrl= '/BackEnd/Admin/vendors/ckfinder/connector?command=QuickUpload&type=Images';
    // config.filebrowserFlashUploadUrl= '/BackEnd/Admin/vendors/ckfinder/connector?command=QuickUpload&type=Flash';
};