#include "widgetmain.h"
#include "ui_widgetmain.h"

WidgetMain::WidgetMain(QWidget *parent) :
    QWidget(parent),
    ui(new Ui::WidgetMain)
{
    ui->setupUi(this);
    labelLinkStatus=ui->labelLinkStatus;
    labelSocket=ui->labelSocket;
    LineEditIPAddress=ui->LineEditIPAddress;
    LineEditPort=ui->LineEditPort;
    btnConnect=ui->btnConnect;
    listWidgetShowMessage=ui->listWidgetShowMessage;

    tcpClient=new QTcpSocket(this);
    tcpClient->abort();//取消原有连接
    labelLinkStatus->setText("当前未建立连接");
    labelSocket->setText("");
    ui->widgetSendMessage->setVisible(false);

    connect(tcpClient,SIGNAL(readyRead()),this,SLOT(ReadData()));
    ui->labelDateShow->setText(QDateTime::currentDateTime().toString("当前日期：yyyy-M-d"));
    DATE_FORMAT="hh:mm:ss";
}

WidgetMain::~WidgetMain() {
    delete ui;
}

void WidgetMain::on_btnConnect_clicked() {
    if (btnConnect->text()=="建立连接") {
        tcpClient->connectToHost(LineEditIPAddress->text(),LineEditPort->text().toInt());
        if (tcpClient->waitForConnected(1000)) {
            btnConnect->setText("断开连接");
            labelLinkStatus->setText("连接服务器成功");
            labelSocket->setText(LineEditIPAddress->text()+":"+LineEditPort->text());
            ui->widgetSocket->setVisible(false);
            ui->widgetSendMessage->setVisible(true);
        }
    }
    else {
        tcpClient->disconnectFromHost();
        if (tcpClient->state() == QAbstractSocket::UnconnectedState)
        {
            btnConnect->setText("建立连接");
            labelLinkStatus->setText("断开连接成功");
            labelSocket->setText("");
            ui->widgetSocket->setVisible(true);
            ui->widgetSendMessage->setVisible(false);
        }
    }
}

void WidgetMain::on_btnSend_clicked()
{
    QString dataSend=ui->lineEditSendMessage->text();
    if (dataSend != "") {
        tcpClient->write(dataSend.toUtf8());
    }
    ui->lineEditSendMessage->setText("");
    QListWidgetItem *item=new QListWidgetItem (dataSend+"  ["+QDateTime::currentDateTime().toString(DATE_FORMAT)+" 已发送]");
    listWidgetShowMessage->addItem(item);
    listWidgetShowMessage->setCurrentRow(listWidgetShowMessage->count()-1);
}

void WidgetMain::on_btnClose_clicked()
{
    this->close();
}
void WidgetMain::ReadData()
{
    qDebug()<<"lml";
    QByteArray buffer=tcpClient->readAll();
    if (!buffer.isEmpty())
    {
        QListWidgetItem *item=new QListWidgetItem (QString(buffer)+"  ["+QDateTime::currentDateTime().toString(DATE_FORMAT)+" 已接收]");
        listWidgetShowMessage->addItem(item);
        listWidgetShowMessage->setCurrentRow(listWidgetShowMessage->count()-1);
    }
}
