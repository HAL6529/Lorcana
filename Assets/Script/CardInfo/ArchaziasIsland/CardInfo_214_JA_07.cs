using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_214_JA_07 : CardInfo
{
    public CardInfo_214_JA_07()
    {
        this.cardNo = "214_JA_07";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "ヒロ・ハマダ";
        this.cardName2 = "アーマー設計者";
        this.power = 4;
        this.toughness = 6;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.RachelElese;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald, EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift5 };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
