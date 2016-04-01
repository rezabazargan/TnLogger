## TnLogger

TnLogger is a simple Logger used in Tispoon project

> **Why:**

> - you can creates your own interpreters to compile objects to a log model
> - you can create your own providers to manage store log models.
> - you can config your interpreters and providers easily.



#### <i class="icon-pencil"></i> create an interpreter
> ex: to interpret an exception

```
class ExceptionInterpreter : IInterpreter
    {
        public Func<object, bool> When
        {
            get
            {
                return c => {
                    return c.GetType() == typeof(Exception);
                };
            }
        }

        public ILogModel Interprete(object obj)
        {
            Exception ex = (Exception)obj;
            return new LogModel() {
                CreateDate = DateTime.Now,
                Description = ex.Message,
                Title = "Exception",
                LogType = LogType.Error,
                Periority = Periority.High,
                User = ""
            };
        }
    }
```

### create a Provider to store the log

```
public class StoreProvider : IProvider
    {
        public static List<ILogModel> Errors = new List<ILogModel>();

        public Func<ILogModel, bool> Condition
        {
            get
            {
                return c => {
                    return c.LogType == LogType.Error;
                };
            }
        }

        public void Log(ILogModel log)
        {
            Errors.Add(log);
        }
    }
```

####Config the application

> **note:**
> config  logger in the start of your application

```
LogManager.Config(c => {
                c.AddInterpreter(new ExceptionInterpreter());
                c.AddProvider(new StoreProvider());
            });

```

---

>now you can log your exception every where
```
catch(Exception ex)
   {
        LogManager.Log(ex);
   }
```

>###Nuget Package
> PM> Install-Package TnLogger



