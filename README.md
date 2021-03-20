# CMPT419

CMPT419 Group Project - Avoidance with Unity ML-Agents

Create a Python Virtual Environment:
https://github.com/Unity-Technologies/ml-agents/blob/main/docs/Using-Virtual-Environment.md

Install Python packages:
https://github.com/Unity-Technologies/ml-agents/blob/main/docs/Installation.md

Setting up a new environment in Unity:
https://github.com/Unity-Technologies/ml-agents/blob/main/docs/Learning-Environment-Create-New.md

Training using mlagents-learn:
https://github.com/Unity-Technologies/ml-agents/blob/main/docs/Training-ML-Agents.md


I've pushing an initial commit that has a test scene built from the ground up, independant of the assets of the ml-agents example repo.
The scene allows one to train an agent (the sphere) to move toward the goal (cube).

Once the virtual python environment is working, I trained the neural network with the following:

```sh
mlagents-learn Assets/Training/test1.yaml --run-id run3 --initialize-from=run2
```

The config overrides for the neural network is in the `Assets/Training/test1.yaml` file, it uses the PPO algorithm by default.
There's data of previous runs, labeled run1, run2, run3.  I create a new run each time, using information from the previous run to give the training a 'running start'.
The result is saved as `My Behavior.onnx` in the `results/run#` folder, which I then copied to `Assets/Training/`.  
This file can be hooked into the `BehaviourParameters` component of the agent to see the trained performance. Disable all other instances when doing this.
