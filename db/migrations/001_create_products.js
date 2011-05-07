{
    up:{
        create_table:{
            name:"Products",
            columns:[
                {name:"name",type:"string"},
                {name:"description",type:"string"},
                {name:"price",type:"money"}
            ]
        }
    },
    down:{
        drop_table:"Products"
    }

}