using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_220_JA_09 : CardInfo
{
    public CardInfo_220_JA_09()
    {
        this.cardNo = "220_JA_09";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "ロビン・フッド";
        this.cardName2 = "有能な戦士";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.Noukah;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.Fabled_vol2;
        this.title = EnumController.Title.RobinHood;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Epic;
    }
}
