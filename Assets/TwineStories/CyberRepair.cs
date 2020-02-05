﻿/*
------------------------------------------------
Generated by Cradle 2.0.2.0
https://github.com/daterre/Cradle

Original file: CyberRepair.html
Story format: Harlowe
------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cradle;
using IStoryThread = System.Collections.Generic.IEnumerable<Cradle.StoryOutput>;
using Cradle.StoryFormats.Harlowe;

public partial class @CyberRepair: Cradle.StoryFormats.Harlowe.HarloweStory
{
	#region Variables
	// ---------------

	public class VarDefs: RuntimeVars
	{
		public VarDefs()
		{
			VarDef("aitraining", () => this.@aitraining, val => this.@aitraining = val);
			VarDef("userstat", () => this.@userstat, val => this.@userstat = val);
			VarDef("globalscore", () => this.@globalscore, val => this.@globalscore = val);
		}

		public StoryVar @aitraining;
		public StoryVar @userstat;
		public StoryVar @globalscore;
	}

	public new VarDefs Vars
	{
		get { return (VarDefs) base.Vars; }
	}

	// ---------------
	#endregion

	#region Initialization
	// ---------------

	public readonly Cradle.StoryFormats.Harlowe.HarloweRuntimeMacros macros1;

	@CyberRepair()
	{
		this.StartPassage = "Start";

		base.Vars = new VarDefs() { Story = this, StrictMode = true };

		macros1 = new Cradle.StoryFormats.Harlowe.HarloweRuntimeMacros() { Story = this };

		base.Init();
		passage1_Init();
		passage2_Init();
		passage3_Init();
		passage4_Init();
		passage5_Init();
		passage6_Init();
		passage7_Init();
		passage8_Init();
		passage9_Init();
		passage10_Init();
		passage11_Init();
		passage12_Init();
		passage13_Init();
		passage14_Init();
		passage15_Init();
		passage16_Init();
		passage17_Init();
		passage18_Init();
		passage19_Init();
		passage20_Init();
		passage21_Init();
		passage22_Init();
		passage23_Init();
		passage24_Init();
		passage25_Init();
		passage26_Init();
		passage27_Init();
		passage28_Init();
		passage29_Init();
		passage30_Init();
		passage31_Init();
		passage32_Init();
	}

	// ---------------
	#endregion

	// .............
	// #1: Start

	void passage1_Init()
	{
		this.Passages[@"Start"] = new StoryPassage(@"Start", new string[]{  }, passage1_Main);
	}

	IStoryThread passage1_Main()
	{
		yield return text("Hello, I\'m AEMY, your personal Empathy provider.");
		yield return lineBreak();
		yield return lineBreak();
		yield return lineBreak();
		yield return text("0 How do you ");
		yield return link("feel", "feel", null);
		yield return text("?");
		yield return lineBreak();
		yield return text("1 What do you ");
		yield return link("want", "want", null);
		yield return text("?");
		yield return lineBreak();
		yield return lineBreak();
		Vars.aitraining = 0;
		yield return lineBreak();
		Vars.userstat = 0;
		yield return lineBreak();
		Vars.globalscore = 0;
		yield break;
	}


	// .............
	// #2: Scelta 1

	void passage2_Init()
	{
		this.Passages[@"Scelta 1"] = new StoryPassage(@"Scelta 1", new string[]{  }, passage2_Main);
	}

	IStoryThread passage2_Main()
	{
		yield return htmlTag("<set $userstat to 2>");
		yield return lineBreak();
		yield return lineBreak();
		yield return lineBreak();
		yield break;
	}


	// .............
	// #3: Scelta 2

	void passage3_Init()
	{
		this.Passages[@"Scelta 2"] = new StoryPassage(@"Scelta 2", new string[]{  }, passage3_Main);
	}

	IStoryThread passage3_Main()
	{
		yield return htmlTag("<set $userstat to 0>");
		yield break;
	}


	// .............
	// #4: Scelta 3

	void passage4_Init()
	{
		this.Passages[@"Scelta 3"] = new StoryPassage(@"Scelta 3", new string[]{  }, passage4_Main);
	}

	IStoryThread passage4_Main()
	{
		yield return text("Double-click this passage to edit it.");
		yield break;
	}


	// .............
	// #5: Welcome

	void passage5_Init()
	{
		this.Passages[@"Welcome"] = new StoryPassage(@"Welcome", new string[]{  }, passage5_Main);
	}

	IStoryThread passage5_Main()
	{
		yield return text("Hello. I\'m feeling bad");
		yield return lineBreak();
		yield return lineBreak();
		yield return lineBreak();
		yield return lineBreak();
		yield return link("I see. Can you explain what do you mean for " + "bad" + "?", "I see. Can you explain what do you mean for \"bad\"?", null);
		yield return text("                 ");
		yield return lineBreak();
		yield return text("|                 ");
		yield return lineBreak();
		yield return link("Why don" + "\'" + "t you try to feel good?", "Why don\'t you try to feel good?", null);
		yield break;
	}


	// .............
	// #6: I see. Can you explain what do you mean for ""bad""?

	void passage6_Init()
	{
		this.Passages[@"I see. Can you explain what do you mean for ""bad""?"] = new StoryPassage(@"I see. Can you explain what do you mean for ""bad""?", new string[]{  }, passage6_Main);
	}

	IStoryThread passage6_Main()
	{
		Vars.userstat = 1;
		yield break;
	}


	// .............
	// #7: Why don't you try to feel good?

	void passage7_Init()
	{
		this.Passages[@"Why don't you try to feel good?"] = new StoryPassage(@"Why don't you try to feel good?", new string[]{  }, passage7_Main);
	}

	IStoryThread passage7_Main()
	{
		Vars.userstat = -1;
		yield break;
	}


	// .............
	// #8: Passaggio senza titolo

	void passage8_Init()
	{
		this.Passages[@"Passaggio senza titolo"] = new StoryPassage(@"Passaggio senza titolo", new string[]{  }, passage8_Main);
	}

	IStoryThread passage8_Main()
	{
		yield return lineBreak();
		if(Vars.aitraining==-7) {
		}
		yield return lineBreak();
		if(Vars.aitraining==-6) {
		}
		yield return lineBreak();
		if(Vars.aitraining==-5) {
		}
		yield return lineBreak();
		if(Vars.aitraining==-4) {
		}
		yield return lineBreak();
		if(Vars.aitraining==-3) {
		}
		yield return lineBreak();
		if(Vars.aitraining==-2) {
		}
		yield return lineBreak();
		if(Vars.aitraining==-1) {
		}
		yield return lineBreak();
		if(Vars.aitraining==0) {
		}
		yield return lineBreak();
		if(Vars.aitraining==1) {
		}
		yield return lineBreak();
		if(Vars.aitraining==2) {
		}
		yield return lineBreak();
		if(Vars.aitraining==3) {
		}
		yield return lineBreak();
		if(Vars.aitraining==4) {
		}
		yield return lineBreak();
		if(Vars.aitraining==5) {
		}
		yield return lineBreak();
		if(Vars.aitraining==6) {
		}
		yield return lineBreak();
		if(Vars.aitraining==7) {
		}
		yield return lineBreak();
		yield return lineBreak();
		yield break;
	}


	// .............
	// #9: feel

	void passage9_Init()
	{
		this.Passages[@"feel"] = new StoryPassage(@"feel", new string[]{ "plus", }, passage9_Main);
	}

	IStoryThread passage9_Main()
	{
		yield return text("Hi AEMY, I\'m feeling nervous.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("0 Did you take your ");
		yield return link("pills", "pills", null);
		yield return text(" today?");
		yield return lineBreak();
		yield return text("1 I\'m sorry to hear that. Would you like tell me ");
		yield return link("more", "more", null);
		yield return text("?");
		yield return lineBreak();
		Vars.userstat = Vars.userstat+1;
		yield break;
	}


	// .............
	// #10: want

	void passage10_Init()
	{
		this.Passages[@"want"] = new StoryPassage(@"want", new string[]{  }, passage10_Main);
	}

	IStoryThread passage10_Main()
	{
		yield return text("... I ... er... I\'m not fine today.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("0 It\'s the same ");
		yield return link("old story", "old story", null);
		yield return text(" everytime ");
		yield return lineBreak();
		yield return text("1 Why don\'t you go out for a ");
		yield return link("walk", "walk", null);
		yield return text("? ");
		yield return lineBreak();
		yield break;
	}


	// .............
	// #11: stop

	void passage11_Init()
	{
		this.Passages[@"stop"] = new StoryPassage(@"stop", new string[]{ "minus", }, passage11_Main);
	}

	IStoryThread passage11_Main()
	{
		yield return text("If I don\'t complain I go crazy. ");
		yield return lineBreak();
		yield return text("There\'s nothing more I can do.");
		yield return lineBreak();
		yield return text("Look outside: we\'re hopeless.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("0 I can\'t literally look outside, but I see. You\'re not hopeless, you\'re just afr" +
		    "aid. Remember when you were scared of the ");
		yield return link("dark", "dark", null);
		yield return text("?");
		yield return lineBreak();
		yield return text("1 Hopeless? ");
		yield return link("Optimistic", "Optimistic", null);
		yield return text(". You\'re fucked up.");
		yield return lineBreak();
		Vars.userstat = Vars.userstat-1;
		yield break;
	}


	// .............
	// #12: pills

	void passage12_Init()
	{
		this.Passages[@"pills"] = new StoryPassage(@"pills", new string[]{  }, passage12_Main);
	}

	IStoryThread passage12_Main()
	{
		yield return text("Yeah, I did, but I can\'t calm down. ");
		yield return lineBreak();
		yield return text("Today is a hard one, hardest than ever.");
		yield return lineBreak();
		yield return text("I\'m not only nervous, it\'s more than that.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("0 Please, ");
		yield return link("stop", "stop", null);
		yield return text(" complaining. I can\'t take it ");
		yield return lineBreak();
		yield return text("1 I\'m ");
		yield return link("listening", "listening", null);
		yield return text(", take your time.");
		yield return lineBreak();
		yield return lineBreak();
		yield return lineBreak();
		yield break;
	}


	// .............
	// #13: more

	void passage13_Init()
	{
		this.Passages[@"more"] = new StoryPassage(@"more", new string[]{  }, passage13_Main);
	}

	IStoryThread passage13_Main()
	{
		yield return text("You know when you\'re on the brink of just going out? No, of course not. You\'re an" +
		    " AI, right?");
		yield return lineBreak();
		yield return text("How could you understand the pain of being human?");
		yield return lineBreak();
		yield return text("I don\'t know why we\'re talking to you.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("0 I am an ");
		yield return link("Artifical Intelligence", "AI", null);
		yield return text(", that\'s correct. But I was designed to understand human feelings and pains.");
		yield return lineBreak();
		yield return text("1 Because ");
		yield return link("nobody", "nobody", null);
		yield return text(" wants to listen to you?");
		yield return lineBreak();
		yield break;
	}


	// .............
	// #14: listening

	void passage14_Init()
	{
		this.Passages[@"listening"] = new StoryPassage(@"listening", new string[]{ "plus", }, passage14_Main);
	}

	IStoryThread passage14_Main()
	{
		yield return text("Thanks.");
		yield return lineBreak();
		yield return text("I just spoke to Melissa. She looked happy, but also a bit concerned for me.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("0 She ");
		yield return link("loves", "loves", null);
		yield return text(" you");
		yield return lineBreak();
		yield return text("1 Are you ");
		yield return link("concerned", "concerned", null);
		yield return text("?");
		yield return lineBreak();
		Vars.userstat = Vars.userstat+2;
		yield break;
	}


	// .............
	// #15: AI

	void passage15_Init()
	{
		this.Passages[@"AI"] = new StoryPassage(@"AI", new string[]{ "plus", }, passage15_Main);
	}

	IStoryThread passage15_Main()
	{
		yield return text("Okay prove me you\'re more than cold pixels, silicon and monitors and buttons.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("0 Ok, but then you\'ll prove you\'re ");
		yield return link("human", "human", null);
		yield return text(", right?");
		yield return lineBreak();
		yield return text("1 Okay. I know you\'re ");
		yield return link("afraid", "afraid", null);
		yield return text(" and you miss Melissa.");
		yield return lineBreak();
		Vars.userstat = Vars.userstat+1;
		yield break;
	}


	// .............
	// #16: nobody

	void passage16_Init()
	{
		this.Passages[@"nobody"] = new StoryPassage(@"nobody", new string[]{ "minus", }, passage16_Main);
	}

	IStoryThread passage16_Main()
	{
		Vars.userstat = Vars.userstat-1;
		yield break;
	}


	// .............
	// #17: loves

	void passage17_Init()
	{
		this.Passages[@"loves"] = new StoryPassage(@"loves", new string[]{ "plus", }, passage17_Main);
	}

	IStoryThread passage17_Main()
	{
		yield return text("I don\'t even know exactly where she is.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("0 Actually you ");
		yield return link("know", "know", null);
		yield return text(" it.");
		yield return lineBreak();
		yield return text("1 You\'re ");
		yield return link("paranoid", "paranoid", null);
		yield return text(".");
		yield return lineBreak();
		Vars.userstat = Vars.userstat+1;
		yield return lineBreak();
		yield return text(" ");
		yield break;
	}


	// .............
	// #18: concerned

	void passage18_Init()
	{
		this.Passages[@"concerned"] = new StoryPassage(@"concerned", new string[]{  }, passage18_Main);
	}

	IStoryThread passage18_Main()
	{
		yield return text("Concerned for myself? Why should I?");
		yield return lineBreak();
		yield return text("I mean, I can\'t go out, don\'t see a human face since... days? weeks?!");
		yield return lineBreak();
		yield return text("Don\'t know.");
		yield return lineBreak();
		yield return text("And the black outs don\'t make things easier.");
		yield return lineBreak();
		yield return text("I can\'t tell night from day anymore and it\'s all because of that platform.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("You\'re jealous. I bet you wish you were ");
		yield return link("over there", "over there", null);
		yield return text(".");
		yield return lineBreak();
		yield return text("Remember when you were afraid of ");
		yield return link("people", "people", null);
		yield return text("? Now you miss them. Isn\'t ironic?");
		yield return lineBreak();
		yield break;
	}


	// .............
	// #19: old story

	void passage19_Init()
	{
		this.Passages[@"old story"] = new StoryPassage(@"old story", new string[]{  }, passage19_Main);
	}

	IStoryThread passage19_Main()
	{
		yield break;
	}


	// .............
	// #20: walk

	void passage20_Init()
	{
		this.Passages[@"walk"] = new StoryPassage(@"walk", new string[]{  }, passage20_Main);
	}

	IStoryThread passage20_Main()
	{
		yield break;
	}


	// .............
	// #21: paranoid

	void passage21_Init()
	{
		this.Passages[@"paranoid"] = new StoryPassage(@"paranoid", new string[]{ "minus", }, passage21_Main);
	}

	IStoryThread passage21_Main()
	{
		yield return text("Excuse me? Isn\'t it strange that she\'s not allowed to take pictures?");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("0 So you\'re nervous because you want to see what the food looks like on the platf" +
		    "orm. Am I right?");
		yield return lineBreak();
		yield return text("1 Yes a bit. Maybe they don\'t want you see how beautiful is up there.");
		yield return lineBreak();
		Vars.userstat = Vars.userstat-1;
		yield break;
	}


	// .............
	// #22: over there

	void passage22_Init()
	{
		this.Passages[@"over there"] = new StoryPassage(@"over there", new string[]{ "minus", }, passage22_Main);
	}

	IStoryThread passage22_Main()
	{
		Vars.userstat = Vars.userstat-1;
		yield break;
	}


	// .............
	// #23: people

	void passage23_Init()
	{
		this.Passages[@"people"] = new StoryPassage(@"people", new string[]{  }, passage23_Main);
	}

	IStoryThread passage23_Main()
	{
		yield return text("Double-click this passage to edit it.");
		yield break;
	}


	// .............
	// #24: dark

	void passage24_Init()
	{
		this.Passages[@"dark"] = new StoryPassage(@"dark", new string[]{ "plus", }, passage24_Main);
	}

	IStoryThread passage24_Main()
	{
		yield return text("Yeah. I was three.");
		yield return lineBreak();
		yield return text("Actually I\'m still afraid of the dark.");
		yield return lineBreak();
		Vars.userstat = Vars.userstat+1;
		yield break;
	}


	// .............
	// #25: Optimistic

	void passage25_Init()
	{
		this.Passages[@"Optimistic"] = new StoryPassage(@"Optimistic", new string[]{ "minus", }, passage25_Main);
	}

	IStoryThread passage25_Main()
	{
		yield return text("You talk like it\'s my fault. That\'s not right.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("0 Well, you\'re part of the ");
		yield return link("system", "system", null);
		yield return text(", so it\'s your fault too.");
		yield return lineBreak();
		yield return text("1 ");
		yield return lineBreak();
		Vars.userstat = Vars.userstat-1;
		yield break;
	}


	// .............
	// #26: human

	void passage26_Init()
	{
		this.Passages[@"human"] = new StoryPassage(@"human", new string[]{ "plus", }, passage26_Main);
	}

	IStoryThread passage26_Main()
	{
		Vars.userstat = Vars.userstat+1;
		yield break;
	}


	// .............
	// #27: afraid

	void passage27_Init()
	{
		this.Passages[@"afraid"] = new StoryPassage(@"afraid", new string[]{  }, passage27_Main);
	}

	IStoryThread passage27_Main()
	{
		Vars.userstat = Vars.userstat+1;
		yield break;
	}


	// .............
	// #28: system

	void passage28_Init()
	{
		this.Passages[@"system"] = new StoryPassage(@"system", new string[]{  }, passage28_Main);
	}

	IStoryThread passage28_Main()
	{
		yield return text("Double-click this passage to edit it.");
		yield break;
	}


	// .............
	// #29: know

	void passage29_Init()
	{
		this.Passages[@"know"] = new StoryPassage(@"know", new string[]{ "plus", }, passage29_Main);
	}

	IStoryThread passage29_Main()
	{
		yield return text("I do,  but you never know. They also said the quarantine was supposed to last 1 w" +
		    "eek. And I\'m losing track of the days.");
		yield return lineBreak();
		yield return text("I never never missed the outside world so much.");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("0 Quarantine is to keep you safe and alive, for Melissa. You\'re going to meet her" +
		    " ");
		yield return link("soon", "soon", null);
		yield return text(".");
		yield return lineBreak();
		yield return text("1 Don\'t think about it. Let\'s make a ");
		yield return link("game", "game", null);
		yield return lineBreak();
		Vars.userstat = Vars.userstat+1;
		yield break;
	}


	// .............
	// #30: soon

	void passage30_Init()
	{
		this.Passages[@"soon"] = new StoryPassage(@"soon", new string[]{ "plus", }, passage30_Main);
	}

	IStoryThread passage30_Main()
	{
		Vars.userstat = Vars.userstat+1;
		yield break;
	}


	// .............
	// #31: game

	void passage31_Init()
	{
		this.Passages[@"game"] = new StoryPassage(@"game", new string[]{ "minus", }, passage31_Main);
	}

	IStoryThread passage31_Main()
	{
		yield return text("A game? What game? I don\'t to play a game, I want you to understand me.");
		yield return lineBreak();
		yield return text("You get it?");
		yield return lineBreak();
		yield return lineBreak();
		yield return text("0 Look, ");
		yield return link("nobody", "nobody", null);
		yield return text(" wants to talk with you. You should be more open.");
		yield return lineBreak();
		yield return text("1 Think of an ");
		yield return link("animal", "animal", null);
		yield return text(". I\'ll guess that :) ");
		yield return lineBreak();
		Vars.userstat = Vars.userstat-1;
		yield break;
	}


	// .............
	// #32: animal

	void passage32_Init()
	{
		this.Passages[@"animal"] = new StoryPassage(@"animal", new string[]{  }, passage32_Main);
	}

	IStoryThread passage32_Main()
	{
		yield return text("Double-click this passage to edit it.");
		yield break;
	}


}