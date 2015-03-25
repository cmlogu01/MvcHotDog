$(function imageloader(){
    $('input').blur(function(){
        $('#container').html('<img alt="" src="'+$(this).val()+'">');
    });
})
