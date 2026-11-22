using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_238_JA_10 : CardInfo
{
    public CardInfo_238_JA_10()
    {
        this.cardNo = "238_JA_10";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ゴライアス";
        this.cardName2 = "一族のリーダー";
        this.power = 6;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MarianaMuGaliano;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Gargoyle };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.Gargoyles;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
