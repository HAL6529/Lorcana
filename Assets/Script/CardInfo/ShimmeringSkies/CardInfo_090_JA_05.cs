using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_090_JA_05 : CardInfo
{
    public CardInfo_090_JA_05()
    {
        this.cardNo = "090_JA_05";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ƒNƒ‰ƒ‰ƒxƒ‹";
        this.cardName2 = "–ž‘«‚°‚È•Ç‚Ì‰Ô";
        this.power = 2;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LissetteCarrera;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
