from flask import Flask

app = Flask(__name__)

@app.route("/")
def home():
    return """
    <h1>SWE40006 Deployment Task 4.2</h1>
    <h2>Docker Container Deployment</h2>
    <p>Student: Daniel Johannson Tan</p>
    <p>This Flask application is running successfully inside a Docker container.</p>
    """

if __name__ == "__main__":
    app.run(host="0.0.0.0", port=5000)
