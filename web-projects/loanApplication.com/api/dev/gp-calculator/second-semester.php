<?php require_once '../config/connection.php'; ?>

<?php
/////////////////  TO ACCEPT INPUT FROM USER //////
$DBMS201 = trim($_POST['DBMS201']);
$UIUX202 = trim($_POST['UIUX202']);
$AI203 = trim($_POST['AI203']);
$SQT204 = trim($_POST['SQT204']);
$AA205 = trim($_POST['AA205']);
$DevOps206 = trim($_POST['DevOps206']);


//////////variable validation////////
if($DBMS201 ===""){ 
    $response = [
        'response' => 100,
        'success' => false,
        'message'=>" DBMS201 REQUIRED! Provide DBMS201 and try again.",
    ];
	goto end;
}
if($UIUX202 ===""){ 
    $response = [
        'response' => 101,
        'success' => false,
        'message'=>" UIUX202 REQUIRED! Provide UIUX202 and try again.",
    ];
	goto end;
}

if($AI203 ===""){ 
    $response = [
        'response' => 102,
        'success' => false,
        'message'=> " AI203 REQUIRED! Provide AI203 and try again.",
    ];
	goto end;
}

if($SQT204 ===""){ 
    $response = [
        'response' => 103,
        'success' => false,
        'message'=>" SQT204 REQUIRED! Provide SQT204 and try again.",
    ];
	goto end;
}

if($AA205 ===""){ 
    $response = [
        'response' => 104,
        'success' => false,
        'message'=>" AA205 REQUIRED! Provide AA205 and try again.",
    ];
	goto end;
}

if($DevOps206 ===""){ 
    $response = [
        'response' => 105,
        'success' => false,
        'message'=>" AGD106 REQUIRED! Provide AGD106 and try again.",
    ];
	goto end;
}

/////////////////  VALIDATE NUMERIC VALUES ////////////////////////////

if (!is_numeric($DBMS201) ||($DBMS201 < 0) || ($DBMS201 > 100)) {
    $response = [
        'response' => 106,
        'success' => false,
        'message' => "INVALID DBMS201! ENTER ONLY NUMERIC VALUE between 0 and 100.",
    ];
    goto end;
}

if (!is_numeric($UIUX202) ||($UIUX202 < 0) || ($UIUX202 > 100)) {
    $response = [
        'response' => 107,
        'success' => false,
        'message' => "INVALID UIUX202! ENTER ONLY  NUMERIC VALUE between 0 and 100.",
    ];
    goto end;
}

if (!is_numeric($AI203) ||($AI203 < 0) || ($AI203 > 100)) {
    $response = [
        'response' => 108,
        'success' => false,
        'message' => "INVALID AI203! ENTER ONLY  NUMERIC VALUE between 0 and 100.",
    ];
    goto end;
}

if (!is_numeric($SQT204) || ($SQT204 < 0) || ($SQT204 > 100)) {
    $response = [
        'response' => 109,
        'success' => false,
        'message' => "INVALID SQT204! ENTER ONLY  NUMERIC VALUE between 0 and 100.",
    ];
    goto end;
}

if (!is_numeric($AA205) ||($AA205 < 0) || ($AA205 > 100)) {
    $response = [
        'response' => 110,
        'success' => false,
        'message' => "INVALID AA205! ENTER ONLY  NUMERIC VALUE between 0 and 100.",
    ];
    goto end;
}

if (!is_numeric($DevOps206) ||($DevOps206 < 0) || ($DevOps206 > 100)) {
    $response = [
        'response' => 111,
        'success' => false,
        'message' => "INVALID DevOps206! ENTER ONLY  NUMERIC VALUE between 0 and 100.",
    ];
    goto end;
};





If (($DBMS201 >= 80) && ($DBMS201 <= 100)){
    $Gradepoint1 = 5 * 4; }
ElseIf (($DBMS201 >= 70) && ($DBMS201 <= 79.9)){
    $Gradepoint1 = 5 * 3.5;}
ElseIf (($DBMS201 >= 60) && ($DBMS201 <= 69.9)) {
    $Gradepoint1 = 5 * 3;}
ElseIf (($DBMS201 >= 50) && ($DBMS201 <= 59.9)) {
    $Gradepoint1 = 5 * 2.5;}
ElseIf (($DBMS201 >= 40) && ($DBMS201 <= 49.9)) {
    $Gradepoint1 = 5 * 2;}
ElseIf (($DBMS201 >= 0) && ($DBMS201 <= 39.9)){
    $Gradepoint1 = 5 * 0;}



If (($UIUX202 >= 80) && ($UIUX202 <= 100)){
    ($Gradepoint2 = (3 * 4)); }
ElseIf (($UIUX202 >= 70) && ($UIUX202 <= 79.9)){
    $Gradepoint2 = 3 * 3.5;}
ElseIf (($UIUX202 >= 60) && ($UIUX202 <= 69.9)) {
    $Gradepoint2 = 3 * 3;}
ElseIf (($UIUX202 >= 50) && ($UIUX202 <= 59.9)) {
    $Gradepoint2 = 3 * 2.5;}
ElseIf (($UIUX202 >= 40) && ($UIUX202 <= 49.9)) {
    $Gradepoint2 = 3 * 2;}
ElseIf (($UIUX202 >= 0) && ($UIUX202 <= 39.9)){
    $Gradepoint2 = 3 * 0;}


If (($AI203 >= 80) && ($AI203 <= 100)){
    ($Gradepoint3 = (5 * 4)); }
ElseIf (($AI203 >= 70) && ($AI203 <= 79.9)){
    $Gradepoint3 = 5 * 3.5;}
ElseIf (($AI203 >= 60) && ($AI203 <= 69.9)) {
    $Gradepoint3 = 5 * 3;}
ElseIf (($AI203 >= 50) && ($AI203 <= 59.9)) {
    $Gradepoint3 = 5 * 2.5;}
ElseIf (($AI203 >= 40) && ($AI203 <= 49.9)) {
    $Gradepoint3 = 5 * 2;}
ElseIf (($AI203 >= 0) && ($AI203 <= 39.9)){
    $Gradepoint3 = 5 * 0;}

If (($SQT204 >= 80) && ($SQT204 <= 100)){
    ($Gradepoint4 = (3 * 4)); }
ElseIf (($SQT204 >= 70) && ($SQT204 <= 79.9)){
    $Gradepoint4 = 3 * 3.5;}
ElseIf (($SQT204 >= 60) && ($SQT204 <= 69.9)) {
    $Gradepoint4 = 3 * 3;}
ElseIf (($SQT204 >= 50) && ($SQT204 <= 59.9)) {
    $Gradepoint4 = 3 * 2.5;}
ElseIf (($SQT204 >= 40) && ($SQT204 <= 49.9)) {
    $Gradepoint4 = 3 * 2;}
ElseIf (($SQT204 >= 0) && ($SQT204 <= 39.9)){
    $Gradepoint4 = 3 * 0;}


If (($AA205 >= 80) && ($AA205 <= 100)){
    ($Gradepoint5 = (4 * 4)); }
ElseIf (($AA205 >= 70) && ($AA205 <= 79.9)){
    $Gradepoint5 = 4 * 3.5;}
ElseIf (($AA205 >= 60) && ($AA205 <= 69.9)) {
    $Gradepoint5 = 4 * 3;}
ElseIf (($AA205 >= 50) && ($AA205 <= 59.9)) {
    $Gradepoint5 = 4 * 2.5;}
ElseIf (($AA205 >= 40) && ($AA205 <= 49.9)) {
    $Gradepoint5 = 4 * 2;}
ElseIf (($AA205 >= 0) && ($AA205 <= 39.9)){
    $Gradepoint5 = 4 * 0;}

If (($DevOps206 >= 80) && ($DevOps206 <= 100)){
    ($Gradepoint6 = (4 * 4)); }
ElseIf (($DevOps206 >= 70) && ($DevOps206 <= 79.9)){
    $Gradepoint6 = 4 * 3.5;}
ElseIf (($DevOps206 >= 60) && ($DevOps206 <= 69.9)) {
    $Gradepoint6 = 4 * 3;}
ElseIf (($DevOps206 >= 50) && ($DevOps206 <= 59.9)) {
    $Gradepoint6 = 4 * 2.5;}
ElseIf (($DevOps206 >= 40) && ($DevOps206 <= 49.9)) {
    $Gradepoint6 = 4 * 2;}
ElseIf (($DevOps206 >= 0) && ($DevOps206 <= 39.9)){
    $Gradepoint6 = 4 * 0;}


    $TGP = $Gradepoint1 + $Gradepoint2 + $Gradepoint3 + $Gradepoint4 + $Gradepoint5 + $Gradepoint6;
    $TCU = 24;
    $GPA = $TGP / $TCU;

    $response = [
        'response' => 203,
        'success' => True,
        'totalGradePoint ' => $TGP,
        'totalCourseUnit ' => $TCU,
        'gradePointAverage ' => $GPA,
        'message' => "The GRADE POINT AVERAGE is $GPA",
    ];





////////////////////////// Print result /////////
end:
echo json_encode($response);
?>