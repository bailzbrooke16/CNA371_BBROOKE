# Belgium Campus Admission Checker
 A basic console app that tells you if you can get into Belgium Campus IT programs. 

## What it does

It asks you some questions about your matric (NSC) and marks, then tells you what you can study. The requirements are:

**You NEED matric first** - has to be certified by Umalusi (or SAQA if you're from overseas)

**Then for each program:**
- **Diploma in IT** - just need NSC endorsed for diploma (easiest one)
- **Bachelor of IT (BIT)** - NSC for degree + 50% English + 50% Maths  
- **Bachelor of Computing (BComp)** - NSC for degree + 50% English + 70% Maths 


## How to run it

I've set it up with Docker so it works everywhere:

**If you havent cloned the repo**

```
docker run -it baileycoding/cna371_bbrooke
```
**With Docker:**
```
docker build -t baileycoding/cna371_bbrooke .
docker run -it baileycoding/cna371_bbrooke
```

**With Docker Compose:**
```
docker-compose up --build
```

**With Kubernetes:**
```
kubectl apply -f k8s/
```

