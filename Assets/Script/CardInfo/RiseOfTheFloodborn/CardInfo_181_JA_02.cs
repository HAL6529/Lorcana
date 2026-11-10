using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_181_JA_02 : CardInfo
{
    public CardInfo_181_JA_02()
    {
        this.cardNo = "181_JA_02";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ヘラクレス";
        this.cardName2 = "神聖なるヒーロー";
        this.power = 6;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.GraceTran;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Prince, EnumController.Class.Deity };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift4, EnumController.KeywordAvility.Resist2 };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
