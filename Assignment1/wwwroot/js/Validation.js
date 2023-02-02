
const pmname = document.getElementById('pmname')
const asset = document.getElementById('asset')
const schedules = document.getElementById('schedules')
const assignedto = document.getElementById('assigned')
const form = document.getElementById('form')
const errorElement = document.getElementById('error')

form.addEventListener('submit', (e) => {
    let messages = []
    if (pmname.value === '' || pmname.value == null) {
        messages.push('Name is required')
    }
    if (pmname.value == isNumeric {
        messages.push('Numbers not accepted')
    }


    if (asset.value == isNumeric {
        messages.push('Numbers not accepted')
    }
    if (schedules.value === '' || name.value == null) {
        messages.push('Schedule is required')
    }
    if (assignedto.value === '' || assignedto.value == null) {
        messages.push('Name is required')
    }
    if (assignedto.value == isNumeric {
        messages.push('Numbers not accepted')
    }
    if (messages.length > 0) {
        e.preventDefault()
        errorElement.innerText = messages.join(', ')
    }
})