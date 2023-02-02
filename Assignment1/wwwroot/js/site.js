// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


// this script is for modal of custom dashboard

let customDash = document.querySelector('.custom-dashboard');



let addDashboardBtn = document.querySelector('.addtoDashboard');



addDashboardBtn.addEventListener('click', (e) => {
    //console.log(e.target);
    customDash.style.display = 'block';
    //console.log(customDash.style);
});



const deselect = document.getElementById('deselect');



deselect.addEventListener('click', () => {
    const tasktype = document.getElementsByName('tasktype');
    tasktype.forEach(item => {
        item.checked = false;
    })
});



const select = document.getElementById('select');



select.addEventListener('click', () => {
    const tasktype = document.getElementsByName('tasktype');
    tasktype.forEach(item => {
        item.checked = true;
    })
});



const dropdownLink = document.querySelector('.dropdownLink');



const priorityList = document.querySelectorAll('.priorityList');
priorityList.forEach(item => {
    item.addEventListener('click', () => {
        dropdownLink.textContent = item.textContent;
    })
});



const dueDropdownLink = document.querySelector('.dueDropdownLink');



const dueList = document.querySelectorAll('.dueList');



dueList.forEach(item => {
    item.addEventListener('click', () => {
        dueDropdownLink.textContent = item.textContent;
    })
});



const functionSelect = document.getElementsByName('function');



const hiddenForm = document.querySelector('.hiddenForm');



functionSelect[0].addEventListener('click', () => {
    hiddenForm.classList.remove('d-none');
});
functionSelect[1].addEventListener('click', () => {
    hiddenForm.classList.add('d-none');
});
functionSelect[2].addEventListener('click', () => {
    hiddenForm.classList.add('d-none');
});



const viewtype = document.getElementsByName('viewtype');
const linegraph = document.querySelector('.line-graph');



viewtype.forEach(item => {
    if (item.value === 'Line Graph') {
        item.addEventListener('click', () => {
            linegraph.classList.remove('d-none');
        });
    }
    else {
        item.addEventListener('click', () => {
            linegraph.classList.add('d-none');
        });
    }
});



const option = document.querySelectorAll('.option');
const check = document.querySelectorAll('.fa-check');



option.forEach(item => {
    item.addEventListener('click', () => {
        const color = '#E0FFDC';
        item.style.backgroundColor = color;
        item.style.border = '1px solid green';
    });
});



const deselectTeam = document.getElementById('deselectTeam');



const team = document.querySelectorAll('.option-team');



deselectTeam.addEventListener('click', () => {
    team.forEach(item => {
        item.style.border = 'border: 1px solid black';
        item.style.backgroundColor = 'rgb(248, 248, 248)';
    });
});



const selectTeam = document.getElementById('selectTeam');



selectTeam.addEventListener('click', () => {
    team.forEach(item => {
        item.style.border = '1px solid green';
        item.style.backgroundColor = '#E0FFDC';
    });
});



const deselectUser = document.getElementById('deselectUser');



const user = document.querySelectorAll('.option-user');



deselectUser.addEventListener('click', () => {
    user.forEach(item => {
        item.style.border = 'border: 1px solid black';
        item.style.backgroundColor = 'rgb(248, 248, 248)';
    });
});



const selectUser = document.getElementById('selectUser');



selectUser.addEventListener('click', () => {
    user.forEach(item => {
        item.style.border = '1px solid green';
        item.style.backgroundColor = '#E0FFDC';
    });
});



const assignee_yes = document.getElementById('assignee_yes');
const assignee_no = document.getElementById('assignee_no');
const assignment = document.querySelector('.assignment');



assignee_yes.addEventListener('click', () => {
    assignment.classList.remove('d-none');
});
assignee_no.addEventListener('click', () => {
    assignment.classList.add('d-none');
});



const deselectLocation = document.getElementById('deselectLocation');



const locationn = document.querySelectorAll('.option-location');



deselectLocation.addEventListener('click', () => {
    locationn.forEach(item => {
        item.style.border = 'border: 1px solid black';
        item.style.backgroundColor = 'rgb(248, 248, 248)';
    });
});
const selectLocation = document.getElementById('selectLocation');



selectLocation.addEventListener('click', () => {
    locationn.forEach(item => {
        item.style.border = '1px solid green';
        item.style.backgroundColor = '#E0FFDC';
    });
});



const locationDiv = document.querySelector('.location');
const location_yes = document.getElementById('location_yes');
const location_no = document.getElementById('location_no');



location_yes.addEventListener('click', () => {
    locationDiv.classList.remove('d-none');
});
location_no.addEventListener('click', () => {
    locationDiv.classList.add('d-none');
});



const assetDiv = document.querySelector('.assets');
const assetgroup_yes = document.getElementById('assetgroup_yes');
const assetgroup_no = document.getElementById('assetgroup_no');



assetgroup_yes.addEventListener('click', () => {
    assetDiv.classList.remove('d-none');
});
assetgroup_no.addEventListener('click', () => {
    assetDiv.classList.add('d-none');
});



const advanced = document.querySelector('.advanced');
const adv_yes = document.getElementById('adv_yes');
const adv_no = document.getElementById('adv_no');



adv_yes.addEventListener('click', () => {
    advanced.classList.remove('d-none');S
});
adv_no.addEventListener('click', () => {
    advanced.classList.add('d-none');
});


//-------------------------------------------------------ritesh -------------------------------------------------------------------------------

// $("#").checked(function () {
//     $("#toch id").animate({ height:12px, color:blue ,})
// })




// 
$("#checkid").change(function(){
    $(".btn-check").prop("checked", $(this).prop("checked"))
} )
$(".btn-check").change(function(){
    if($(this).prop("checked")==false){
        $("#checkid").prop("checked", false)
    }
    if($(".btn-check:checked").length==$(".btn-check").length)
    { $("#checkid").prop("checked", true)
}
})