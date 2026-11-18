using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_049_JA_08 : CardInfo
{
    public CardInfo_049_JA_08()
    {
        this.cardNo = "049_JA_08";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "リナ・セイブルウィング";
        this.cardName2 = "エネルギー体";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.FedericoMariaCugliari;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst, EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.DuckTales;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
