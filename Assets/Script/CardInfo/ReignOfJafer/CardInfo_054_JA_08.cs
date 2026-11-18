using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_054_JA_08 : CardInfo
{
    public CardInfo_054_JA_08()
    {
        this.cardNo = "054_JA_08";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "メグ";
        this.cardName2 = "たくらみの加担者";
        this.power = 2;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.SamantaErdini;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
