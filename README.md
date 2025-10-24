# Belgium Campus Admission Checker

This is my CNA371 project - a simple console app that checks if students qualify for different IT programs at Belgium Campus.

## What it does

The app asks students for their info and tells them which programs they can apply for:
- Diploma in IT (need 40%+ with Maths and English)
- Bachelor of IT (need 60%+ with Maths, English and Science)  
- Bachelor of Computing (need 70%+ with all subjects)

## How to run it

I've set it up with Docker so it works everywhere:

**With Docker:**
```
docker build -t admission-app .
docker run -it admission-app
```

**With Docker Compose:**
```
docker-compose up --build
```

**With Kubernetes:**
```
kubectl apply -f k8s/
```

## Files included

- `Program.cs` - the main C# code
- `Dockerfile` - to build the container
- `docker-compose.yml` - for easy deployment
- `k8s/` folder - Kubernetes setup
