
const taskInput = document.getElementById("taskInput");
const addTaskBtn = document.getElementById("addTaskBtn");
const taskList=document.getElementById("taskList");

addTaskBtn.addEventListener("click", addTask);

function addTask(){
    console.log("buttonclicked");
    const newText = taskInput.value.trim();
    if(newText===""){
        alert("Enter a Task!!!");
        return;
    }
    //creating the task list
    const li=document.createElement("li");
    const span=document.createElement("span");
    span.textContent=newText;
    const completeBtn=document.createElement("button");
    completeBtn.textContent="Complete";
        completeBtn.addEventListener("click",() => {

            if(!span.textContent.includes("(Completed)")){
                const confirmComplete= confirm("Are you sure you want to mark  this task as completed?");
                if(confirmComplete){
                     span.textContent= newText+"   (Completed)";
                     span.style.color="green";
                }
            }
            else{
                alert("Task Already Completed!!!");
                return;
            }
    
    });


    const deleteBtn=document.createElement("button");
    deleteBtn.textContent="Delete Task";
    deleteBtn.addEventListener("click",() => {
        const confirmDelete= confirm("Are you sure you want to delete this task?");
        if(confirmDelete){
        taskList.removeChild(li);
        }
    });

    li.appendChild(span);
    li.appendChild(completeBtn);
    li.appendChild(deleteBtn);
    taskList.appendChild(li);
    taskInput.value="";

}