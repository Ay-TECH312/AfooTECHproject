<?php require_once '../config/connection.php'; ?>

<?php

/////////////////  TO ACCEPT INPUT FROM USER //////
$SDT101=trim($_POST['SDT101']);
$MAD102=trim($_POST['MAD102']);
$WAD104=trim($_POST['WAD104']);
$NS105=trim($_POST['NS105']);
$SDA103=trim($_POST['SDA103']);
$AGD106=trim($_POST['AGD106']);

//////////variable validation////////
if($SDT101 ===""){ 
    $response = [
        'response' => 100,
        'success' => false,
        'message'=>" SDT101 REQUIRED! Provide SDT101 and try again.",
    ];
	goto end;
}
if($MAD102 ===""){ 
    $response = [
        'response' => 101,
        'success' => false,
        'message'=>" MAD102 REQUIRED! Provide MAD102 and try again.",
    ];
	goto end;
}

if($SDA103 ===""){ 
    $response = [
        'response' => 102,
        'success' => false,
        'message'=> " SDA103 REQUIRED! Provide SDA103 and try again.",
    ];
	goto end;
}

if($WAD104 ===""){ 
    $response = [
        'response' => 103,
        'success' => false,
        'message'=>" WAD104 REQUIRED! Provide WAD104 and try again.",
    ];
	goto end;
}

if($NS105 ===""){ 
    $response = [
        'response' => 104,
        'success' => false,
        'message'=>" NS105 REQUIRED! Provide NS105 and try again.",
    ];
	goto end;
}

if($AGD106 ===""){ 
    $response = [
        'response' => 105,
        'success' => false,
        'message'=>" AGD106 REQUIRED! Provide AGD106 and try again.",
    ];
	goto end;
}

/////////////////  VALIDATE NUMERIC VALUES ////////////////////////////

if (!is_numeric($SDT101) ||($SDT101 < 0) || ($SDT101 > 100)) {
    $response = [
        'response' => 106,
        'success' => false,
        'message' => "INVALID SDT101! ENTER ONLY NUMERIC VALUE between 0 and 100.",
    ];
    goto end;
}

if (!is_numeric($MAD102) ||($MAD102 < 0) || ($MAD102 > 100)) {
    $response = [
        'response' => 107,
        'success' => false,
        'message' => "INVALID MAD102! ENTER ONLY  NUMERIC VALUE between  0 and 100.",
    ];
    goto end;
}

if (!is_numeric($SDA103) ||($SDA103 < 0) || ($SDA103 > 100)) {
    $response = [
        'response' => 108,
        'success' => false,
        'message' => "INVALID SDA103! ENTER ONLY  NUMERIC VALUE between 0 and 100.",
    ];
    goto end;
}

if (!is_numeric($WAD104) || ($WAD104 < 0) || ($WAD104 > 100)) {
    $response = [
        'response' => 109,
        'success' => false,
        'message' => "INVALID WAD104! ENTER ONLY  NUMERIC VALUE between 0 and 100.",
    ];
    goto end;
}

if (!is_numeric($NS105) ||($NS105 < 0) || ($NS105 > 100)) {
    $response = [
        'response' => 110,
        'success' => false,
        'message' => "INVALID NS105! ENTER ONLY  NUMERIC VALUE between 0 and 100.",
    ];
    goto end;
}

if (!is_numeric($AGD106) ||($AGD106 < 0) || ($AGD106 > 100)) {
    $response = [
        'response' => 111,
        'success' => false,
        'message' => "INVALID AGD106! ENTER ONLY  NUMERIC VALUE between 0 and 100.",
    ];
    goto end;
};

    If (($SDT101 >= 80) && ($SDT101 <= 100)){
        $Gradepoint1 = 4 * 4; }
    ElseIf (($SDT101 >= 70) && ($SDT101 <= 79.9)){
        $Gradepoint1 = 4 * 3.5;}
    ElseIf (($SDT101 >= 60) && ($SDT101 <= 69.9)) {
        $Gradepoint1 = 4 * 3;}
    ElseIf (($SDT101 >= 50) && ($SDT101 <= 59.9)) {
        $Gradepoint1 = 4 * 2.5;}
    ElseIf (($SDT101 >= 40) && ($SDT101 <= 49.9)) {
        $Gradepoint1 = 4 * 2;}
    ElseIf (($SDT101 >= 0) && ($SDT101 <= 39.9)){
        $Gradepoint1 = 4 * 0;}



    If (($MAD102 >= 80) && ($MAD102 <= 100)){
        ($Gradepoint2 = (4 * 4)); }
    ElseIf (($MAD102 >= 70) && ($MAD102 <= 79.9)){
        $Gradepoint2 = 4 * 3.5;}
    ElseIf (($MAD102 >= 60) && ($MAD102 <= 69.9)) {
        $Gradepoint2 = 4 * 3;}
    ElseIf (($MAD102 >= 50) && ($MAD102 <= 59.9)) {
        $Gradepoint2 = 4 * 2.5;}
    ElseIf (($MAD102 >= 40) && ($MAD102 <= 49.9)) {
        $Gradepoint2 = 4 * 2;}
    ElseIf (($MAD102 >= 0) && ($MAD102 <= 39.9)){
        $Gradepoint2 = 4 * 0;}


    If (($SDA103 >= 80) && ($SDA103 <= 100)){
        ($Gradepoint3 = (5 * 4)); }
    ElseIf (($SDA103 >= 70) && ($SDA103 <= 79.9)){
        $Gradepoint3 = 5 * 3.5;}
    ElseIf (($SDA103 >= 60) && ($SDA103 <= 69.9)) {
        $Gradepoint3 = 5 * 3;}
    ElseIf (($SDA103 >= 50) && ($SDA103 <= 59.9)) {
        $Gradepoint3 = 5 * 2.5;}
    ElseIf (($SDA103 >= 40) && ($SDA103 <= 49.9)) {
        $Gradepoint3 = 5 * 2;}
    ElseIf (($SDA103 >= 0) && ($SDA103 <= 39.9)){
        $Gradepoint3 = 5 * 0;}

    If (($WAD104 >= 80) && ($WAD104 <= 100)){
        ($Gradepoint4 = (4 * 4)); }
    ElseIf (($WAD104 >= 70) && ($WAD104 <= 79.9)){
        $Gradepoint4 = 4 * 3.5;}
    ElseIf (($WAD104 >= 60) && ($WAD104 <= 69.9)) {
        $Gradepoint4 = 4 * 3;}
    ElseIf (($WAD104 >= 50) && ($WAD104 <= 59.9)) {
        $Gradepoint4 = 4 * 2.5;}
    ElseIf (($WAD104 >= 40) && ($WAD104 <= 49.9)) {
        $Gradepoint4 = 4 * 2;}
    ElseIf (($WAD104 >= 0) && ($WAD104 <= 39.9)){
        $Gradepoint4 = 4 * 0;}


    If (($NS105 >= 80) && ($NS105 <= 100)){
        ($Gradepoint5 = (4 * 4)); }
    ElseIf (($NS105 >= 70) && ($NS105 <= 79.9)){
        $Gradepoint5 = 4 * 3.5;}
    ElseIf (($NS105 >= 60) && ($NS105 <= 69.9)) {
        $Gradepoint5 = 4 * 3;}
    ElseIf (($NS105 >= 50) && ($NS105 <= 59.9)) {
        $Gradepoint5 = 4 * 2.5;}
    ElseIf (($NS105 >= 40) && ($NS105 <= 49.9)) {
        $Gradepoint5 = 4 * 2;}
    ElseIf (($NS105 >= 0) && ($NS105 <= 39.9)){
        $Gradepoint5 = 4 * 0;}

    If (($AGD106 >= 80) && ($AGD106 <= 100)){
        ($Gradepoint6 = (4 * 4)); }
    ElseIf (($AGD106 >= 70) && ($AGD106 <= 79.9)){
        $Gradepoint6 = 4 * 3.5;}
    ElseIf (($AGD106 >= 60) && ($AGD106 <= 69.9)) {
        $Gradepoint6 = 4 * 3;}
    ElseIf (($AGD106 >= 50) && ($AGD106 <= 59.9)) {
        $Gradepoint6 = 4 * 2.5;}
    ElseIf (($AGD106 >= 40) && ($AGD106 <= 49.9)) {
        $Gradepoint6 = 4 * 2;}
    ElseIf (($AGD106 >= 0) && ($AGD106 <= 39.9)){
        $Gradepoint6 = 4 * 0;}


        $TGP = $Gradepoint1 + $Gradepoint2 + $Gradepoint3 + $Gradepoint4 + $Gradepoint5 + $Gradepoint6;
        $TCU = 25;
        $GPA = $TGP / $TCU;

        $response = [
            'response' => 203,
            'success' => True,
            'totalGradePoint' => $TGP,
            'totalCourseUnit' => $TCU,
            'gradePointAverage' => $GPA,
            'message' => "The GRADE POINT AVERAGE is $GPA",
        ];

////////////////////////// Print result /////////
end:
echo json_encode($response);
?>