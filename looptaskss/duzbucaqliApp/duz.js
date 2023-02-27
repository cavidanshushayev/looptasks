let hun=4
let en= 4
for(let i=1;i<=hun;i++){
    for(j=1;j<=en;j++){
        if(i==1 || i==hun){
           console.log("*"); 
        }
        else if(j==1 || j==en){
            console.log("*")
        }else {
            console.log(" ")
        }
    
    }
    console.log('\n')
}