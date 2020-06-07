export class DataDto {
    constructor(data = {}) {
        this.msgData = {
            userName : data.userName,
            messageDate : data.date
        };
        this.content = data.content;
    }
}

export default {
    DataDto,
}