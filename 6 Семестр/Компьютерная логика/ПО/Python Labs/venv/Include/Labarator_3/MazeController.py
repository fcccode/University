''' Управление роботом '''
def maze_controller(runner):
    while not (runner.found()):
        if runner.go():
            if runner.found() == False:
                runner.turn_right()
                if runner.go():
                    if runner.found() == False:
                        runner.go()
                        runner.go()
                else:
                    runner.turn_left()
                    runner.turn_left()
                    if runner.go():
                        runner.found()
                    else:
                        runner.turn_right()
        else:
            runner.turn_left()
            if runner.go():
                runner.found()
            else:
                runner.turn_right()
                runner.turn_right()
