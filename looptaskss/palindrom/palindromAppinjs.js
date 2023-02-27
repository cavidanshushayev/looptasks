let eded=443
let a=0
let ters =0
let m=eded
while(eded>0){
    a=eded%10
    ters=ters*10 +a
    eded=eded/10
}
if (ters == m){
    console.log("polindromdur");
}else {
    console.log("polindrom deyil");
}