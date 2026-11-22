using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_122_JA_10 : CardInfo
{
    public CardInfo_122_JA_10()
    {
        this.cardNo = "122_JA_10";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "エリサ・マーザ";
        this.cardName2 = "大胆不敵な捜査官";
        this.power = 4;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.PalomaSauvage;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Detective };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.Gargoyles;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
