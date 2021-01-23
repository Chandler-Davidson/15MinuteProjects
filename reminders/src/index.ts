import schedule from "node-schedule"
import { sendText } from "./sendText";
import { messages } from "./messages";

const { MEGAN_NUMBER } = process.env as any;
const cronSchedule = "*/4 * * * *";

setTimeout(() => {
  schedule.scheduleJob(cronSchedule, async () => {
    const message = getRandomElement(messages);
    const text = await sendText(MEGAN_NUMBER, message);

    console.log(`${text.sid}\t${message}`)
  });
}, 5000);

const getRandomElement = (arr: Array<any>) => {
  const { floor, random } = Math;

  return arr[floor(random() * arr.length)];
}