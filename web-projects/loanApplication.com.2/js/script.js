function _actionModal(action) {
    if (action === 'open') {
        $('#modal').css('display', 'flex');
    } else if (action === 'close') {
        $('#modal').css('display', 'none').fadeOut(200);
    }
}


function _loanRequest() {
    const fullName = $('#fullName').val();
    const loanAmount = $('#loanAmount').val();
    const loanRate = $('#loanRate').val();
    const loanDuration = $('#loanDuration').val();

    if (!fullName) {
        alert('Provide fullname to continue.');
        return;
    }

    const namePattern = /^[a-zA-Z\s.'-]{2,}$/;
    if (!namePattern.test(fullName)) {
        alert('Full name contains invalid characters.');
        return;
    }

    if (!loanAmount) {
        alert('Provide loan amount to continue.');
        return;
    }

    if (!Number(loanAmount)) {
        alert('Loan amount must be a number.');
        return;
    }

    if (loanAmount <= 5000 || loanAmount > 10000000) {
        alert('Loan amount must be between 5,000 and 10,000,000.');
        return;
    }

    if (!loanRate) {
        alert('Provide loan rate to continue.');
        return;
    }

    const parsedLoanRate = parseFloat(loanRate);
    if (!parsedLoanRate) {
        alert('Loan rate must be a number.');
        return;
    }

    if (parsedLoanRate < 1 || parsedLoanRate > 100) {
        alert('Loan rate must be between 1% and 100%.');
        return;
    }

    if (!loanDuration) {
        alert('Select loan duration to continue.');
        return;
    }

    const parsedLoanDuration = parseInt(loanDuration);
    if (!parsedLoanDuration) {
        alert('Loan duration must be a number.');
        return;
    }

    const allowedDurations = [6, 10, 12, 24];
    if (!allowedDurations.includes(parsedLoanDuration)) {
        alert('Select a valid loan duration: 6, 10, 12, or 24 months.');
        return;
    }

    let totalInterest = 0;
    let totalMonthlyRepayment = 0;
    let principal = loanAmount;
    const repayment = loanAmount / loanDuration;
    let text='';

    for (let month = 1; month <= loanDuration; month++) {
        const interestOnLoan = (loanRate / 100) * principal;
        const monthlyRepayment = repayment + interestOnLoan;

        text=`
            <tbody>
                <tr>
                    <td>${month}</td>
                    <td>${repayment}</td>
                    <td>${interestOnLoan}</td>
                    <td>${monthlyRepayment}</td>
                    <td>${principal}</td>
                </tr>
            </tbody>
        `;
        $('#loanBreakdown').append(text);

        principal -= repayment;
        totalInterest += interestOnLoan;
        totalMonthlyRepayment += monthlyRepayment;
    }

    alert('Loan Requested succefully');
    _clear();
}

function _clear() {
    $('#fullName, #loanAmount, #loanRate, #loanDuration').val('');
}


