#ifndef WIDGETMAIN_H
#define WIDGETMAIN_H

#include <QWidget>
#include"QLabel"
#include "QTcpSocket"
#include"QLineEdit"
#include"QPushButton"
#include"QListWidget"
#include"QDateTime"

namespace Ui {
class WidgetMain;
}

class WidgetMain : public QWidget
{
    Q_OBJECT

public:
    explicit WidgetMain(QWidget *parent = 0);
    ~WidgetMain();

private slots:
    void on_btnConnect_clicked();

    void on_btnSend_clicked();

    void on_btnClose_clicked();
    void ReadData();
private:
    Ui::WidgetMain *ui;
    QLabel *labelLinkStatus;
    QLabel *labelSocket;
    QLineEdit *LineEditIPAddress;
    QLineEdit *LineEditPort;
    QTcpSocket *tcpClient;
    QPushButton *btnConnect;
    QListWidget *listWidgetShowMessage;
    QString DATE_FORMAT;
};

#endif // WIDGETMAIN_H
