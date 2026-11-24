using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_194_JA_12 : CardInfo
{
    public CardInfo_194_JA_12()
    {
        this.cardNo = "194_JA_12";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ファーガス";
        this.cardName2 = "砦の建設者";
        this.power = 4;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.KennethAnderson;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Mentor, EnumController.Class.King };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Brave;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
