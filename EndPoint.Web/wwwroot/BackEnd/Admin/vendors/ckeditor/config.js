/**
 * @license Copyright (c) 2003-2019, CKSource - Frederico Knabben. All rights reserved.
 * For licensing, see https://ckeditor.com/legal/ckeditor-oss-license
 */

CKEDITOR.editorConfig = function( config ) {
    config.language = 'fa';
    config.extraPlugins = 'image';
    // config.contentsCss = '/fonts/font.css';
    // config.contentsCss = 'BackEnd/Admin/vendors/ckeditor_4.13.1_full/fonts/font.css';
    // config.font_names = 'IRANYekan-fa;' + config.font_names;


    // config.font_names = 'IRANYekan-fa;IRANSansWeb';
    // config.font_defaultLabel = 'IRANYekan-fa';
    // config.fontSize_defaultLabel = '11px';
    config.filebrowserBrowseUrl= '/BackEnd/Admin/vendors/ckfinder/ckfinder.html';
    config.filebrowserUploadUrl= '/BackEnd/Admin/vendors/ckfinder/connector?command=QuickUpload&type=Files';

    // config.filebrowserImageBrowseUrl= '/BackEnd/Admin/vendors/ckfinder/ckfinder.html?type=Images';
    // config.filebrowserFlashBrowseUrl= '/BackEnd/Admin/vendors/ckfinder/ckfinder.html?type=Flash';
    // config.filebrowserImageUploadUrl= '/BackEnd/Admin/vendors/ckfinder/connector?command=QuickUpload&type=Images';
    // config.filebrowserFlashUploadUrl= '/BackEnd/Admin/vendors/ckfinder/connector?command=QuickUpload&type=Flash';
};
