using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_090_JA_11 : CardInfo
{
    public CardInfo_090_JA_11()
    {
        this.cardNo = "090_JA_11";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "トッド";
        this.cardName2 = "やんちゃな子ぎつね";
        this.power = 2;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MaliaEwart;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.TheFoxAndTheHound;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
