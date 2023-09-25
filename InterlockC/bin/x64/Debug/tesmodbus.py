from pyModbusTCP.client import ModbusClient
import time
import os
import mysql.connector
import datetime

db = mysql.connector.connect(
  host="127.0.0.1",
  user="pintu",
  passwd="pintu321",
  database="control_pintu"
)

ip_m = []
id_modbus = []
status_m = []
status_p = []
status_pintu = ""
status_pintulive = ""
def show_data(db):
  try:
    db.connect()
    cursor = db.cursor()
    sql = "SELECT * FROM live_data"
    cursor.execute(sql)
    x = cursor.fetchall() 
    if cursor.rowcount < 0:
      print("Tidak ada data")
    else:
        for y in x:
          ip_m.append(y[3])
          id_modbus.append(y[4])
          status_m.append(y[5])
          status_p.append(y[8])
          print("--------------------------------")
          print (ip_m,"  ",id_modbus,"  ",status_m,"  ",status_p)
          print("--------------------------------")
  except:
    print("error show")
    db.close()
  finally:
    db.close()

def update_data(db):
  try:
    db.connect()
    cursor = db.cursor()
    sql = """UPDATE live_data SET detail_status=%s WHERE id_modbus=%s AND ip_pintu=%s"""
    val = (status_pintu, id_modbus[i], ip_m[i])
    print(val)
    cursor.execute(sql, val)
    db.commit()
    print("{} data berhasil diubah".format(cursor.rowcount))
  except:
    print("error update")
  finally:
    db.close()

def update_dataX(db):
  try:
    db.connect()
    cursor = db.cursor()
    datatime = datetime.datetime.now()
    dataT = str(datatime)
    timed = dataT.split(".")
    timex = timed[0]
    sql = """UPDATE live_data SET Status_M=%s WHERE id_modbus=%s AND ip_pintu=%s"""
    val = (status_pintulive, id_modbus[i], ip_m[i])
    print(val)
    cursor.execute(sql, val)
    db.commit()
    print("{} data berhasil diubah".format(cursor.rowcount))
  except:
    print("error update")
  finally:
    db.close()

while True:
    time.sleep(1)
    os.system('cls')
    ip_m = []
    id_modbus = []
    status_m = []
    status_p = []
    show_data(db)
    for i in range(0,29):
      try:
        c = ModbusClient(host=ip_m[i],port=502, auto_open=True, auto_close=True)
        coildt=c.write_single_coil(id_modbus[i], status_m[i])
        regs = c.read_coils(id_modbus[i],1)
        regsX = c.read_coils(status_p[i],1)
        if regs[0] == True:
            status_pintu = "OPEN"
        elif regs[0] == False:
            status_pintu = "CLOSE"

        if regsX[0] == True:
            status_pintulive = "OPEN"
        elif regsX[0] == False:
            status_pintulive = "CLOSE"
        print(i," : ",coildt, "--",regs[0], "--",regsX[0])
        update_data(db)
        update_dataX(db)
      except:
        pass
