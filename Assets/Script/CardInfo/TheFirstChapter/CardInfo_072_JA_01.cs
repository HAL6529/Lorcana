using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_072_JA_01 : CardInfo
{
    public CardInfo_072_JA_01()
    {
        this.cardNo = "072_JA_01";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ƒNƒ‹ƒGƒ‰";
        this.cardName2 = "‚¢‚Â‚¾‚Á‚Ä•…‚è‚Ç‚¨‚µ‚æ";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = "Nicholas Kole";
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.AliceInWonderland;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
