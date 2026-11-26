using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_037_JA_14 : CardInfo
{
    public CardInfo_037_JA_14()
    {
        this.cardNo = "037_JA_14";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "デイビッド・ザナトス";
        this.cardName2 = "魔術に手を出す実業家";
        this.power = 6;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.EduFrancisco;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Gargoyles;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
