import axios from "axios";

const url = "https://localhost:7103/api";

export const GetAllWomen = async() => {

    try{

        const res=await axios.get(url + "/Women").then(res => {
                console.log("res:",res.data)
                return res;
            })
    }
  catch(e){
    throw e;

  }
}