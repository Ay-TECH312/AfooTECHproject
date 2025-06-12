const namePattern = /^[a-zA-Z\s.'-]{2,}$/;

function _actionModal(action) {
    if (action === 'open') {
        $('#modal').css('display', 'flex');
    } else if (action === 'close') {
        $('#modal').css('display', 'none').fadeOut(200);
    }
}
function _loanRequest() {
    const fullName = $('#fullName').val();
    const loanAmount = parseFloat($('#loanAmount').val());
    const loanRate = parseFloat($('#loanRate').val());
    const loanDuration = parseInt($('#loanDuration').val());


    if (!fullName) {
        alert('Provide fullname to continue.');
        return;
    }

    if (!namePattern.test(fullName)) {
        alert('Full name contains invalid characters.');
        return;
    }

    if (!Number(loanAmount) || loanAmount <= 0) {
        alert('Loan amount must be a valid number.');
        return;
    }

    if (loanAmount <= 5000 || loanAmount > 10000000) {
        alert('Loan amount must be between 5,000 and 10,000,000.');
        return;
    }

    if (!Number(loanRate) || loanRate < 1 || loanRate > 100) {
        alert('Loan rate must be between 1% and 100%.');
        return;
    }

    const allowedDurations = [6, 10, 12, 24];
    if (!allowedDurations.includes(loanDuration)) {
        alert('Select a valid loan duration: 6, 10, 12, or 24 months.');
        return;
    }

   

    let totalInterest = 0;
    let totalMonthlyRepayment = 0;
    let principal = loanAmount;
    const repayment = loanAmount / loanDuration;

    for (let month = 1; month <= loanDuration; month++) {
        const interestOnLoan = (loanRate / 100) * principal;
        const monthlyRepayment = repayment + interestOnLoan;

        const row = `
            <tr>
                <td>${month}</td>
                <td>${repayment}</td>
                <td>${interestOnLoan}</td>
                <td>${monthlyRepayment}</td>
                <td>${principal}</td>
            </tr>
        `;

        $('#loanBreakdown').append(row);

        principal -= repayment;
        totalInterest += interestOnLoan;
        totalMonthlyRepayment += monthlyRepayment;
    }

    alert('Loan Requested successfully');
    _clear();
}

function _clear() {
    $('#fullName, #loanAmount, #loanRate, #loanDuration').val('');
}
