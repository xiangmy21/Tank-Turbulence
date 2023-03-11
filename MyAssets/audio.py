import ffmpeg

# 输入文件
input_file = "fire.mp3"

# 输出文件
output_file = "output.mp3"

# 裁剪开始时间
start_time = 0.05

# 裁剪持续时间
duration = None

# 使用FFmpeg裁剪音频文件
ffmpeg.input(input_file, ss=start_time, t=duration).output(output_file).run()
