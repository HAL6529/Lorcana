using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_043_JA_05 : CardInfo
{
    public CardInfo_043_JA_05()
    {
        this.cardNo = "043_JA_05";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "”’‚¤‚³‚¬";
        this.cardName2 = "‰¤‹{‚Ì“`—ß";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JamesCMulligan;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.AliceInWonderland;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
