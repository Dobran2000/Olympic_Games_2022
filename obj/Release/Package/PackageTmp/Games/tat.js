confirmPassword.style.borderColor = 'green' // if password pattern matches the border of password input will ne green
pwd_format.style.color = 'green'
                } else {
    confirmPassword.style.borderColor = 'red'
    pwd_format.style.color = 'red'
}
            })
        })

confirmPassword.addEventListener('focusout', () => {
    pwd_format.style.display = 'none';
})

termCond.addEventListener('change', () => {
    if (termCond.checked === true) {
        signup.disabled = false;
    } else if (termCond.checked === false) {
        signup.disabled = true;
    }
})