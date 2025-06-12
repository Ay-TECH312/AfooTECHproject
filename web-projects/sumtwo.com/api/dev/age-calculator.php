<?php require_once 'config/connection.php'; ?>

<?php
/////////////////  TO ACCEPT INPUT FROM USER //////
$birthDay=trim( $_POST['birthDay']);
$birthMonth=trim($_POST['birthMonth']);
$birthYear=trim( $_POST['birthYear']);

$currentYear = date("Y");
$currentMonth = date("m");
$currentDay = date("d");

$daysInMonth =date('t', mktime(0, 0, 0, $birthMonth, 1, $birthYear));


if($birthDay ===""){ 
    $response = [
        'response' => 100,
        'success' => false,
        'message'=>" BIRTHDAY REQUIRED! Provide BIRTHDAY and try again.",
    ];
	goto end;
}
if (!ctype_digit($birthDay) || ($birthDay > 31) || ($birthDay < 1)){
    $response = [
        'response' => 101,
        'success' => false,
        'message' => "INVALID BIRTHDAY! ENTER THE CORRECT DAY'"
    ];
    goto end;
}

if($birthMonth  ===""){ 
    $response = [
        'response' => 102,
        'success' => false,
        'message'=>" BIRTHMONTH REQUIRED! Provide BIRTHMONTH and try again.",
    ];
	goto end;
}
if (!ctype_digit($birthMonth) || ($birthMonth > 12) || ($birthMonth < 1))  {
    $response = [
        'response' => 103,
        'success' => false,
        'message' => "INVALID BIRTHMONTH! ENTER THE CORRECT MONTH "
    ];
    goto end;
}

if ($birthYear  ===""){ 
    $response = [
        'response' => 104,
        'success' => false,
        'message'=>" BIRTHYEAR REQUIRED! Provide BIRTHYEAR and try again.",
    ];
	goto end;
}
if (!ctype_digit($birthYear) || ($birthYear > $currentYear))  {
    $response = [
        'response' => 105,
        'success' => false,
        'message' => "INVALID BIRTHYEAR!  ENTER THE CORRECT YEAR"
    ];
    goto end;
}

If ($birthYear <= $currentYear) {
$ageYear = $currentYear - $birthYear;
}

//SECURITY FOR THE MONTH
If ($currentMonth >= $birthMonth){
$ageMonth =$currentMonth - $birthMonth;
}
else
{$ageMonth = 12 + $currentMonth - $birthMonth;
    $ageYear -= 1;
}

//SECURITY FOR THE DAY
If ($currentDay >= $birthDay){
$ageDay = $currentDay - $birthDay;
}
else{
$ageMonth -= 1;
$ageDay = $daysInMonth + $currentDay - $birthDay;
}

If ($ageMonth < 0){
$ageMonth = 11;
$ageYear -= 1;
}

If ($ageYear < 0) {
    $response = [
        'response' => 106,
        'success' => false,
        'message' => "INVALID DATE!  ENTER THE CORRECT DATE"
    ];
    goto end;
}
If ($birthDay > $daysInMonth){
    $response = [
        'response' => 107,
        'success' => false,
        'message' => "INVALID DAY!  ENTER THE CORRECT DAY"
    ];
    goto end;
} 

$response = [
    'response' => 200,
    'success' => True,
    'ageYear' => $ageYear,
    'ageMonth' => $ageMonth,
    'ageDay' => $ageDay,
    'message' => "You are $ageYear years, $ageMonth months and $ageDay days old",
];

////////////////////////// Print result /////////
end:
echo json_encode($response);
?>