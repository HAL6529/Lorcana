using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_089_JA_11 : CardInfo
{
    public CardInfo_089_JA_11()
    {
        this.cardNo = "089_JA_11";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "白うさぎ";
        this.cardName2 = "また遅れちまった！";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JiahuiEvaGao;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.AliceInWonderland;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
