import { Twilio } from "twilio";
const { ACCOUNT_SID, AUTH_TOKEN, TWILIO_NUMBER } = process.env as any;

const twilio = new Twilio(ACCOUNT_SID, AUTH_TOKEN);

export const sendText = (recipient: string, message: string) => {
  return twilio.messages.create({
    to: recipient,
    from: TWILIO_NUMBER,
    body: message
  });
}