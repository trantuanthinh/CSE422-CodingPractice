// Question 2
using TestExamCode.Q2;
using TestExamCode.Q2.Interfaces;
using TestExamCode.Q2.Notification;

INotification email1 = new Email();
INotification email2 = new Email();
INotification email3 = new Email();
INotification sms1 = new SMS();
INotification sms2 = new SMS();
INotification sms3 = new SMS();
INotification pushNotification1 = new PushNotification();
INotification pushNotification2 = new PushNotification();
INotification pushNotification3 = new PushNotification();

NotificationSender sender1 = new NotificationSender([email1,email2,email3]);
NotificationSender sender2 = new NotificationSender([sms1,sms2,sms3]);
NotificationSender sender3 = new NotificationSender([pushNotification1,pushNotification2,pushNotification3]);

sender1.Notify("aaaaa");
sender2.Notify("bbbbb");
sender3.Notify("ccccc");