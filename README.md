# Belgium Campus Admission Checker

This is my CNA371 project - a simple console app that checks if students qualify for different IT programs at Belgium Campus.

## What it does

The app checks if students meet Belgium Campus admission requirements based on the official criteria:

**Minimum requirement:** NSC certified by Umalusi or SAQA equivalent foreign qualification

**Programs available:**
- **Diploma in Information Technology** - NSC endorsed for Diploma
- **Bachelor of Information Technology (BIT)** - NSC endorsed for Degree + 50% English + 50% Mathematics  
- **Bachelor of Computing (BComp)** - NSC endorsed for Degree + 50% English + 70% Mathematics

**Special note:** Mathematics Bridging Course available for students who scored less than required in pure mathematics.

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
