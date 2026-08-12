using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_151_JA_01 : CardInfo
{
    public CardInfo_151_JA_01()
    {
        this.cardNo = "151_JA_01";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "マレフィセント";
        this.cardName2 = "招かれざる客";
        this.power = 3;
        this.toughness = 6;
        this.lore = 3;
        this.illustrator = "Gaku Kumatori";
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.SleepingBeauty;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
