#include "splash.h"
#include "ui_splash.h"
splash::splash(QWidget *parent) :
    QWidget(parent),
    ui(new Ui::splash)
{
    ui->setupUi(this);
    widgetMain = new WidgetMain();
}

splash::~splash()
{
    delete ui;
}

void splash::on_btnTCPClient_clicked()
{
    widgetMain->showFullScreen();
}
