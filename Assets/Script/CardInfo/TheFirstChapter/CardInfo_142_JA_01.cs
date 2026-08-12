using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_142_JA_01 : CardInfo
{
    public CardInfo_142_JA_01()
    {
        this.cardNo = "142_JA_01";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ƒxƒ‹";
        this.cardName2 = "”ü‚µ‚¢‚¯‚Ç•Ï‚í‚èŽÒ";
        this.power = 2;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = "Alice Pisoni";
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
