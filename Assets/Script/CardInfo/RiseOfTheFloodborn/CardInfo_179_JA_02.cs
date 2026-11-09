using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_179_JA_02 : CardInfo
{
    public CardInfo_179_JA_02()
    {
        this.cardNo = "179_JA_02";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "イーライ・ラバフ";
        this.cardName2 = "ビッグ・ダディ";
        this.power = 2;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.IsaiahMesq;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Mentor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.ThePrincessAndTheFrog;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
