let eded =100
let say=0
let cem =0
for(let i =2;i<eded;i++){
    for (let j=2;j<i;j++){
        if(i%j ==0){
            say=say+1
        }
    }
    if(say<1){
        cem =cem +i;
    }
    say =0;

}
console.log(cem);