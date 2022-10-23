export class CoronaDetails{
    constructor(
         public PersonId:string,
         public CoronaVaccine?:Date,
         public CoronaManufacturer?:string,
         public CoronaVaccine_2?:Date,
         public CoronaManufacturer_2?:string,
         public CoronaVaccine_3?:Date,
         public CoronaManufacturer_3?:string,
         public CoronaVaccine_4?:Date,
         public CoronaManufacturer_4?:string,
         public PositiveForCorona?:Date,
         public RecoveringFromCorona?:Date 
    ){}
      
}