using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_020_JA_08 : CardInfo
{
    public CardInfo_020_JA_08()
    {
        this.cardNo = "020_JA_08";
        this.inkCost = 7;
        this.availableInk = false;
        this.cardName1 = "ブルーノ・マドリガル";
        this.cardName2 = "歌う予言者";
        this.power = 3;
        this.toughness = 7;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MilicaCelikovic;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Ally, EnumController.Class.Madrigal };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber, EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift5 };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
